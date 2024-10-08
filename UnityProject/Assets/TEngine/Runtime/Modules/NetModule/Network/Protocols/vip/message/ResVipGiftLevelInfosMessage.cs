using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * VIP等级礼包信息 message
 */
public class ResVipGiftLevelInfosMessage : Message 
{
	//已领取过礼包的vip等级列表
	List<int> _vipGiftLevelInfos = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//已领取过礼包的vip等级列表
		SerializeUtils.WriteShort(stream, (short)_vipGiftLevelInfos.Count);

		foreach (var element in _vipGiftLevelInfos)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//已领取过礼包的vip等级列表
		int _vipGiftLevelInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _vipGiftLevelInfos_length; ++i) 
		{
			_vipGiftLevelInfos.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * get 已领取过礼包的vip等级列表
	 * @return 
	 */
	public List<int> GetVipGiftLevelInfos()
	{
		return _vipGiftLevelInfos;
	}
	
	/**
	 * set 已领取过礼包的vip等级列表
	 */
	public void SetVipGiftLevelInfos(List<int> vipGiftLevelInfos)
	{
		_vipGiftLevelInfos = vipGiftLevelInfos;
	}
	
	
	public override int GetId() 
	{
		return 313101;
	}
}