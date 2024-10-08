using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 地狱蝶对手列表 message
 */
public class ResButterflyOpponentInfoMessage : Message 
{
	//地狱蝶对手列表
	List<ButterflyOpponentInfo> _butterflyOpponentInfo = new List<ButterflyOpponentInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//地狱蝶对手列表
		SerializeUtils.WriteShort(stream, (short)_butterflyOpponentInfo.Count);

		foreach (var element in _butterflyOpponentInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//地狱蝶对手列表
		int _butterflyOpponentInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _butterflyOpponentInfo_length; ++i) 
		{
			_butterflyOpponentInfo.Add(SerializeUtils.ReadBean<ButterflyOpponentInfo>(stream));
		}
	}
	
	/**
	 * get 地狱蝶对手列表
	 * @return 
	 */
	public List<ButterflyOpponentInfo> GetButterflyOpponentInfo()
	{
		return _butterflyOpponentInfo;
	}
	
	/**
	 * set 地狱蝶对手列表
	 */
	public void SetButterflyOpponentInfo(List<ButterflyOpponentInfo> butterflyOpponentInfo)
	{
		_butterflyOpponentInfo = butterflyOpponentInfo;
	}
	
	
	public override int GetId() 
	{
		return 211205;
	}
}