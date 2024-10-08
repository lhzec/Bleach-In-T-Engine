using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 地狱蝶抢夺纪录 message
 */
public class ResButterflyRobRecordMessage : Message 
{
	//地狱蝶抢夺纪录
	List<ButterflyRobRecord> _butterflyRobRecord = new List<ButterflyRobRecord>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//地狱蝶抢夺纪录
		SerializeUtils.WriteShort(stream, (short)_butterflyRobRecord.Count);

		foreach (var element in _butterflyRobRecord)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//地狱蝶抢夺纪录
		int _butterflyRobRecord_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _butterflyRobRecord_length; ++i) 
		{
			_butterflyRobRecord.Add(SerializeUtils.ReadBean<ButterflyRobRecord>(stream));
		}
	}
	
	/**
	 * get 地狱蝶抢夺纪录
	 * @return 
	 */
	public List<ButterflyRobRecord> GetButterflyRobRecord()
	{
		return _butterflyRobRecord;
	}
	
	/**
	 * set 地狱蝶抢夺纪录
	 */
	public void SetButterflyRobRecord(List<ButterflyRobRecord> butterflyRobRecord)
	{
		_butterflyRobRecord = butterflyRobRecord;
	}
	
	
	public override int GetId() 
	{
		return 211204;
	}
}