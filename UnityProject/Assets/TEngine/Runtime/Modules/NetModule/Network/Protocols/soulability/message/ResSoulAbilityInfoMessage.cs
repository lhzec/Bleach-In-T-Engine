using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 灵魂能力信息 message
 */
public class ResSoulAbilityInfoMessage : Message 
{
	//灵魂能力信息
	List<SoulAbilityInfo> _soulAbilityInfo = new List<SoulAbilityInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//灵魂能力信息
		SerializeUtils.WriteShort(stream, (short)_soulAbilityInfo.Count);

		foreach (var element in _soulAbilityInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//灵魂能力信息
		int _soulAbilityInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _soulAbilityInfo_length; ++i) 
		{
			_soulAbilityInfo.Add(SerializeUtils.ReadBean<SoulAbilityInfo>(stream));
		}
	}
	
	/**
	 * get 灵魂能力信息
	 * @return 
	 */
	public List<SoulAbilityInfo> GetSoulAbilityInfo()
	{
		return _soulAbilityInfo;
	}
	
	/**
	 * set 灵魂能力信息
	 */
	public void SetSoulAbilityInfo(List<SoulAbilityInfo> soulAbilityInfo)
	{
		_soulAbilityInfo = soulAbilityInfo;
	}
	
	
	public override int GetId() 
	{
		return 304300;
	}
}